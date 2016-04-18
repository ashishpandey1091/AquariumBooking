/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/*function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}*/

$(document).ready(function(){
   
    console.log("in home"+$.cookie("username"));
    
    
     
     /* start of on click of links in homepage for exhibits tab**/
     var targetTab = document.getElementById("tabInfo").value; //ViewData["Key"]; //getParameterByName('tab');
    console.log("tabname"+targetTab);
        if(targetTab === 'exone'){
                $("#exonetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exonetarget").show();
        }
        if(targetTab === 'extwo'){
            $("#extwotab").addClass('active');
                $("#exonetab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#exonetarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#extwotarget").show();
        }
        if(targetTab === 'exthree'){
                $("#exthreetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exonetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exthreetarget").show();
        }
        if(targetTab === 'exfour'){
                $("#exfourtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exonetarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfourtarget").show();
        }
        if(targetTab === 'exfive'){
                $("#exfivetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfivetarget").show();
        }
        if(targetTab === 'exsix'){
            $("#exsixtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").hide();
                $("#exsixtarget").show();
        }
        if(targetTab === 'exseven'){
            $("#exseventab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exonetab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").show();
        }
     /* end of on click of links in homepage for exhibits tab**/
     
     
     
    /* start of on click of menu in exhibits page**/
    $("#exonelink").click(function(){
                $("#exonetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exonetarget").show();
          });
          
          $("#extwolink").click(function(){
                $("#extwotab").addClass('active');
                $("#exonetab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#exonetarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#extwotarget").show();
          });
          
          $("#exthreelink").click(function(){
                $("#exthreetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exonetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exthreetarget").show();
          });
          
          $("#exfourlink").click(function(){
                $("#exfourtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exonetarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfourtarget").show();
          });
          
          $("#exfivelink").click(function(){
                $("#exfivetab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exfivetarget").show();
          });
          
          $("#exsixlink").click(function(){
                $("#exsixtab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exonetab").removeClass('active');
                $("#exseventab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").hide();
                $("#exsixtarget").show();
          });
          
           $("#exsevenlink").click(function(){
                $("#exseventab").addClass('active');
                $("#extwotab").removeClass('active');
                $("#exthreetab").removeClass('active');
                $("#exfourtab").removeClass('active');
                $("#exfivetab").removeClass('active');
                $("#exsixtab").removeClass('active');
                $("#exonetab").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exonetarget").hide();
                $("#exseventarget").show();
                
          });
          
    /* end of on click of menu in exhibits page**/
    
    /** start- for click on left menu tabs in exhibits page **/
          $("#exonetab").click(function(){
                $("#exone").addClass('active');
                $("#extwo").removeClass('active');
                $("#exthree").removeClass('active');
                $("#exfour").removeClass('active');
                $("#exfive").removeClass('active');
                $("#exsix").removeClass('active');
                $("#exseven").removeClass('active');
                
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").hide();
                $("#exonetarget").show();
          });
          
          $("#extwotab").click(function(){
              $("#extwo").addClass('active');
              $("#exone").removeClass('active');
              $("#exthree").removeClass('active');
              $("#exfour").removeClass('active');
              $("#exfive").removeClass('active');
              $("#exsix").removeClass('active');
              $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#exonetarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#extwotarget").show();
          });
          
          $("#exthreetab").click(function(){
              $("#exthree").addClass('active');
              $("#exone").removeClass('active');
              $("#extwo").removeClass('active');
              $("#exfour").removeClass('active');
              $("#exfive").removeClass('active');
              $("#exsix").removeClass('active');
              $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exonetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exthreetarget").show();
          });
          
          $("#exfourtab").click(function(){
              $("#exfour").addClass('active');
              $("#exone").removeClass('active');
              $("#exthree").removeClass('active');
              $("#extwo").removeClass('active');
              $("#exfive").removeClass('active');
              $("#exsix").removeClass('active');
              $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exonetarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exfourtarget").show();
          });
          
          $("#exfivetab").click(function(){
              $("#exfive").addClass('active');
              $("#exone").removeClass('active');
              $("#exthree").removeClass('active');
              $("#exfour").removeClass('active');
              $("#extwo").removeClass('active');
              $("#exsix").removeClass('active');
              $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").hide();
                $("#exfivetarget").show();
          });
          
          $("#exsixtab").click(function(){
              $("#exsix").addClass('active');
              $("#exone").removeClass('active');
              $("#exthree").removeClass('active');
              $("#exfour").removeClass('active');
              $("#exfive").removeClass('active');
              $("#extwo").removeClass('active');
              $("#exseven").removeClass('active');
                
                $("#exseventarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exonetarget").hide();
                $("#exsixtarget").show();
                
          });
          
          $("#exseventab").click(function(){
              $("#exseven").addClass('active');
              $("#exone").removeClass('active');
              $("#exthree").removeClass('active');
              $("#exfour").removeClass('active');
              $("#exfive").removeClass('active');
              $("#exsix").removeClass('active');
              $("#extwo").removeClass('active');
                
                $("#exonetarget").hide();
                $("#extwotarget").hide();
                $("#exthreetarget").hide();
                $("#exfourtarget").hide();
                $("#exfivetarget").hide();
                $("#exsixtarget").hide();
                $("#exseventarget").show();
                
          });
          
    /** end- for click on left menu tabs in exhibits page **/
    
    
       
});

