let net;
const webcamElement = document.getElementById('webcam');
var commandHistory = "StandBy";

const classes = ['1', '2', '3', '4', '5', '6', '7', '8', '9', 'Cancel', 'Confirm', 'StandBy', 'Start'];

//const classes = ['Confirm',  'Start','StandBy'];

var chartValues = [];


function createChart() {
    var spec = {
        "$schema": "https://vega.github.io/schema/vega-lite/v2.0.json",
        "description": "A simple bar chart with embedded data.",
        "data": {
            "values": chartValues
        },
        "mark": "bar",
        "encoding": {
            "x": {  "field": "class", "type": "ordinal" },
            "y": { "aggregate": "sum","field": "values", "type": "quantitative" }
        }
    };
    vega.embed("#vis", spec);

}

 
async function app() {





  
  // Put the object into storage

// Retrieve the object from storage
  var retrievedObject = localStorage.getItem('TFMclassifier');



 if(retrievedObject!=null)
{
  
  classifier= knnClassifier.create();
  
 // classifier.setClassifierDataset(JSON.parse(retrievedObject));


} else
{
  classifier= knnClassifier.create();


}

    $('#MessageBox').html("Loading mobilenet..");
  console.log('Loading mobilenet..');
  
    // Load the model.
    net = await mobilenet.load();
    console.log('Successfully loaded model');

    $('#MessageBox').html("Model Loaded");

    await setupWebcam();
  
    // Reads an image from the webcam and associates it with a specific class
    // index.
    const addExample = classId => {
      // Get the intermediate activation of MobileNet 'conv_preds' and pass that
      // to the KNN classifier.

 
      $(".captures").append(webcamElement); 
      
      const activation = net.infer(webcamElement, 'conv_preds');
  
      // Pass the intermediate activation to the classifier.
      classifier.addExample(activation, classId);

      classDS= classifier.getClassifierDataset();

      //localStorage.setItem('TFMclassifier', JSON.stringify(classDS));
  
    };

    const addExampleFromExisting = (imgv, classId) => {
        // Get the intermediate activation of MobileNet 'conv_preds' and pass that
        // to the KNN classifier.


      //  $(".captures").append(imgv);

         $('#MessageBox').html("Adding images to KNN: " + classId + " / " + classes[classId]);

        const activation = net.infer(imgv, 'conv_preds');

        // Pass the intermediate activation to the classifier.

        classifier.addExample(activation, classId);

        classDS = classifier.getClassifierDataset();

        //localStorage.setItem('TFMclassifier', JSON.stringify(classDS));

    };



    $('.thumb').each(function () {


        var img2 = document.createElement('img'); // Use DOM HTMLImageElement


        img2.setAttribute('crossOrigin', 'anonymous');
        img2.src =  $(this).attr('src');  

       

        img2.width = "400";
        img2.height = "400";


        img2.onload = function () {

            let classValue = img2.src.substring(img2.src.lastIndexOf('/') + 1);

            let classValueParsed = classValue.substring(0, classValue.indexOf('_'));

            console.log(classValueParsed);
            //$('#MessageBox').html(classValueParsed);


            var canvas = document.createElement("canvas");
            canvas.width = this.width;
            canvas.height = this.height;

            var ctx = canvas.getContext("2d");
            ctx.drawImage(this, 0, 0);

            var dataURL = canvas.toDataURL("image/png");

            var imageData = dataURL.replace(/^data:image\/(png|jpg);base64,/, "");

            //console.log(imageData);
            addExampleFromExisting(img2, classes.indexOf(classValueParsed));


            chartValues.push({ "class": classValueParsed,"values":1   });    


          

     


        };


    });


  


  
    $('#MessageBox').html("");



    
    while (true) {
      if (classifier.getNumClasses() > 0) {

        // Get the activation from mobilenet from the webcam.
        const activation = net.infer(webcamElement, 'conv_preds');
        // Get the most likely class and confidences from the classifier module.

        const result = await classifier.predictClass(activation);
  
       //   const classes = ['1', '2', '3', '4', '5', '6', '7', '8', '9','cancel', 'confirm', 'select','start' ];


          $('#MessageBox').html("");

          //console.log(result.confidences);


          if (result.label != null) {



        /*    document.getElementById('console').innerText = `
          prediction ID: ${result.label}\n
          prediction: ${classes[result.label]}\n
          probability: ${result.confidences[result.label]}\n
          clases: ${JSON.stringify(classes)}\n
          confidences: ${JSON.stringify(result.confidences)}
        `;

         */

             // console.log(classes[result.classIndex]);

              if (result.confidences[result.label] == null) {  }

              commandSelection = classes[result.label];

              if (commandSelection == "StandBy") { $('#MessageBox').html("Stand By"); }
              if (commandSelection == "Start") {

                  $('#happy').click();
                //  $('#Display').removeClass();
                 // $('#Display').addClass('alert-success alert-dismissible fade show');

                  $('#MessageBox').html("Hello!");

              }
              else if (commandSelection == "Cancel") {
                  $('#MessageBox').html("Cancel");
                  $('#angry').click();
               //   $('#MessageBox').html("");
                //  $('#Display').removeClass();
              } else if (commandSelection == "2") {

                  $('#MessageBox').html("Confirm number Two?");
                 //   $('#MessageBox').html("");
                  //  $('#Display').removeClass();
              }

              else if (commandSelection == "Confirm") {
                  if (commandHistory == "2");
                  alert('confirmed number 2');

                  $('#normal').click();
                  $('#happy').click();
                  //   $('#MessageBox').html("");s
                  //  $('#Display').removeClass();
              }

              else {

                  $('#normal').click();
                  //   $('#MessageBox').html("");
                  //  $('#Display').removeClass();
              }


              commandHistory = commandSelection;

          }


      }
  
      await tf.nextFrame();
    }
  }


async function setupWebcam() {
    return new Promise((resolve, reject) => {
      const navigatorAny = navigator;
      navigator.getUserMedia = navigator.getUserMedia ||
          navigatorAny.webkitGetUserMedia || navigatorAny.mozGetUserMedia ||
          navigatorAny.msGetUserMedia;
      if (navigator.getUserMedia) {
        navigator.getUserMedia({video: true},
          stream => {
            webcamElement.srcObject = stream;
            webcamElement.addEventListener('loadeddata',  () => resolve(), false);
          },
          error => reject());
      } else {
        reject();
      }
    });
  }
app();