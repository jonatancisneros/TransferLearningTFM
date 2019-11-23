var intervalId;
var initialTime = 3000;

var timing = initialTime;
 //onload

 $(function(){

    Webcam.set({
        width: 320,
        height: 240,
        image_format: 'jpeg',
        jpeg_quality: 90
       });
       Webcam.attach( '#my_camera' );
      
       $('#class-start').click(function (){
           intervalId = window.setInterval(function () {
            
               if (timing == 0) {
                   $('#MessageBox').html("Smile!");
               } else {

                   $('#MessageBox').html("Taking a pic in: " + (timing / 1000));
               }
               if (timing <= 0) {

           
                   timing = initialTime;
                   take_snapshot();
                   
               }

               timing -= 1000;

        }, 1000);
      
      });
      
      $('#class-stop').click(function (){
          clearInterval(intervalId);
          $('#MessageBox').html("Ready to record!");
      });
      

      function removePic(e)
      {
        alert(e);
      
      }
      
      function labelElement(obj)
      {
        alert(obj.parent().id);
      
      }
      
  

 })

function uploadimage(image){

    let img = document.getElementById(image).src;


    let lbl = document.getElementById('sel_' + image).value;



    Webcam.upload(img, 'Home/UploadAsync/' + lbl, function (code, text) {
        alert('Upload complete!');
        // 'code' will be the HTTP response code from the server, e.g. 200
        // 'text' will be the raw response content
    });

}

 function take_snapshot() {
       
    // take snapshot and get image data

    Webcam.snap( function(data_uri) {
        var guid=   createUUID() ;
        var img = '<img class="rounded-circle" id="' +  guid + '" width="60px" height="60px" src="'+data_uri+'"/>';
        var options = '<select id="sel_' + guid + '" class="selLabel">\
            <option id = "Select" >Select</option> \
            <option id = "Start" >Start</option> \
            <option id="confirm">Confirm</option> \
            <option id="cancel">Cancel</option> \
            <option id="one">1</option> \
            <option id="two">2</option> \
            <option id="three">3</option> \
            <option id="four">4</option> \
            <option id="five">5</option> \
            <option id="six">6</option> \
            <option id="seven">7</option> \
            <option id="eight">8</option> \
            <option id="nine">9</option> \
            </select>';


        $("#results").prepend('<div class="Capture">' + options + ' |<a href="#" onClick="javascript:$(this).parent().empty();">Delete</a>|<a href="#" onClick="javascript:uploadimage(\'' + guid  + '\');">Upload</a> <br/> ' + img +  ' <br/></div>');


   
   
     } );
   }

   function createUUID() {
    // http://www.ietf.org/rfc/rfc4122.txt
    var s = [];
    var hexDigits = "0123456789abcdef";
    for (var i = 0; i < 36; i++) {
        s[i] = hexDigits.substr(Math.floor(Math.random() * 0x10), 1);
    }
    s[14] = "4";  // bits 12-15 of the time_hi_and_version field to 0010
    s[19] = hexDigits.substr((s[19] & 0x3) | 0x8, 1);  // bits 6-7 of the clock_seq_hi_and_reserved to 01
    s[8] = s[13] = s[18] = s[23] = "-";

    var uuid = s.join("");
    return uuid;
}