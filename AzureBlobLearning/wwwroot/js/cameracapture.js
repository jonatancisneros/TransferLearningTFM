var intervalId;

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
        intervalId=window.setInterval(function(){
          take_snapshot();
        }, 5000);
      
      });
      
      $('#class-stop').click(function (){
          clearInterval(intervalId); 
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
         var img= '<img id="' +  guid + '" width="160px" height="120px" src="'+data_uri+'"/>';
        var options = '<select id="sel_' + guid + '" class="selLabel"><option id="Start">Start message</option><option id="confirm">Confirm message</option><option id="lightson">Turn lights on</option><option id="lightsoff">lights off</option><option id="cancel">Cancel message</option><option id="weather">Weather</option></select>';
        $("#results").append('<div class="Capture"> Select action  ' + options + '  |<a href="#" onClick="javascript:$(this).parent().empty();">Delete</a>|<a href="#" onClick="javascript:uploadimage(\'' + guid  + '\');">Upload</a> <br/> ' + img +  ' <br/></div>');


   
   
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