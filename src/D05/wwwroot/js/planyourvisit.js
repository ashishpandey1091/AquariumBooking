/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

subtotal = 0.0;
total = 0.0;
adult_price = 12.99;
child_price = 5.99;
adult_price_show = 55.0;
child_price_show = 25.0;
subtotaladult = 0.0;
subtotalchild = 0.0;
totalentryprice = 0.0;
totalshowprice = 0.0;
totalprice = 0.0;
adultqty = 0;
childqty = 0;
adult ="false";
child = "false";
entryTicketAdded = "false";
guide = "no";
meal = "no";
qty = 0;
showname = "null";
discountshowprice = 0.0;
showsBooked = 0;
showCount = 0;
discountPrice = 0.0;
p_coralshow = 0.0;
p_dolphinshow = 0.0;
p_musicshow = 0.0;
showAdded = "false";
mealqty = 0;
lunchplan = "no";
rideqty = 0;
ridePlans = "no";
ridePrice = 30;
entryTicketDescription = "";
entry_desc1 = "";
entry_desc2 = "";
firstName = "";
lastName = "";
contact = "";
email = "";
dateofVisit = "";
shows = new Array();
showPrices = new Array();
userName = "";
ticketId = 0;


function hoursPageClicked() {

}

/*function getParameterByName(name) {
    name = name.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + name + "=([^&#]*)"),
        results = regex.exec(location.search);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
} */

$(document).ready(function () {
    alert("ready");
       
    console.log("in visit us js");
     
    //userName = $.cookie("username");
    //console.log("in home"+$.cookie("username"));
    
    // if(userName == "null" || userName == undefined){
    //        console.log("in if");
    //        $("#myaccount").hide();
    //        $("#loginlinks").show();
    //        $("#username").html(" ");
    // }else{
    //        console.log("in else");
    //        $("#myaccount").show();
    //        $("#loginlinks").hide();
    //        $("#username").html(userName);   
    // }
    
    
   // $("#datepicker").datepicker({dateFormat:'mm/dd/yy'}).datepicker("setDate",new Date());//adddefaultdate
    
    $("#next").hide();
    $("#facilities").hide();
    $("#payment").hide();
    $("#confirm").hide();
    
    $("#lunch").popover({trigger : 'hover'});
    $("#ride").popover({trigger : 'hover'});
    
    $('[data-toggle="tooltip"]').tooltip();
    
    /* start of on click of links in homepage **/
    var targetTab = document.getElementById("tabInfo").value;   // ViewData["Key"];     //getParameterByName('tab');
    console.log("tabname"+targetTab);
    
    if(targetTab === 'hours'){
        /**$("#htab").addClass('active');
        $("#ttab").removeClass('active');
        $("#ftab").removeClass('active');
        $("#ocsntab").removeClass('active');
        $("#fqtab").removeClass('active');**/
        
        $("#ticketstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#hourstab").addClass('active');
        
        $("#tickets").hide();
        $("#find").hide();
        $("#occasions").hide();
        $("#faq").hide();
        $("#hours").show();
    }
    
    if(targetTab === 'tickets'){  
        /**$("#ttab").addClass('active');
        $("#htab").removeClass('active');
        $("#ftab").removeClass('active');
        $("#ocsntab").removeClass('active');
        $("#fqtab").removeClass('active');**/
        
        $("#hourstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#ticketstab").addClass('active');
        $("#ticketprices").hide();
        
        $("#hours").hide();
        $("#find").hide();
        $("#occasions").hide();
        $("#faq").hide();
        $("#tickets").show();
    }
    
    if(targetTab === 'find'){
        /**$("#ftab").addClass('active');
        $("#ttab").removeClass('active');
        $("#htab").removeClass('active');
        $("#ocsntab").removeClass('active');
        $("#fqtab").removeClass('active');**/
                
        $("#hourstab").removeClass('active');
        $("#ticketstab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#findtab").addClass('active');
        
        $("#tickets").hide();
        $("#hours").hide();
        $("#occasions").hide();
        $("#faq").hide();
        $("#find").show();
    }
    
    if(targetTab === 'occasions'){
        /**$("#ocsntab").addClass('active');
        $("#ttab").removeClass('active');
        $("#ftab").removeClass('active');
        $("#htab").removeClass('active');
        $("#fqtab").removeClass('active');**/
        
        $("#hourstab").removeClass('active');
        $("#ticketstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#occsntab").addClass('active');
        
        $("#tickets").hide();
        $("#find").hide();
        $("#hours").hide();
        $("#faq").hide();
        $("#occasions").show();
    }
    
     if(targetTab === 'faq'){
        /**$("#fqtab").addClass('active');
        $("#ttab").removeClass('active');
        $("#ftab").removeClass('active');
        $("#ocsntab").removeClass('active');
        $("#htab").removeClass('active');**/
                
        $("#hourstab").removeClass('active');
        $("#ticketstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").addClass('active');
        
        $("#tickets").hide();
        $("#find").hide();
        $("#occasions").hide();
        $("#hours").hide();
        $("#faq").show();
    }
    /* end of on click of links in homepage **/
    
    /* start of on click of menu in plan your visit page for visitor info tab**/
    $("#hoursli").click(function(){
        
        $("#ticketstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#hourstab").addClass('active');
        $("#tickets").hide();
        $("#find").hide();
        $("#occasions").hide();
        $("#faq").hide();
        $("#hours").show();
    });
    
    $("#ticketsli").click(function(){
        console.log("in click");
        $("#hourstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#ticketstab").addClass('active');
        $("#hours").hide();
        $("#find").hide();
        $("#occasions").hide();
        $("#faq").hide();
        $("#tickets").show();
    });
    
    $("#findli").click(function(){
        $("#hourstab").removeClass('active');
        $("#ticketstab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#findtab").addClass('active');
        
        $("#tickets").hide();
        $("#hours").hide();
        $("#occasions").hide();
        $("#faq").hide();
        $("#find").show();
    });
    
    $("#occsnli").click(function(){
        $("#hourstab").removeClass('active');
        $("#ticketstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#faqtab").removeClass('active');
        $("#occsntab").addClass('active');
        
        $("#tickets").hide();
        $("#find").hide();
        $("#hours").hide();
        $("#faq").hide();
        $("#occasions").show();
    });
    
    $("#faqli").click(function(){
        $("#hourstab").removeClass('active');
        $("#ticketstab").removeClass('active');
        $("#findtab").removeClass('active');
        $("#occsntab").removeClass('active');
        $("#faqtab").addClass('active');
         $("#tickets").hide();
        $("#find").hide();
        $("#occasions").hide();
        $("#hours").hide();
        $("#faq").show();
    });
    /* end of on click of menu in plan your visit page for visit us tab**/
    
    /** start- for click on left menu tabs in plan your visit page **/
          $("#hourstab").click(function(){
                $("#htab").addClass('active');
                $("#ttab").removeClass('active');
                $("#ftab").removeClass('active');
                $("#ocsntab").removeClass('active');
                $("#fqtab").removeClass('active');
                $("#tickets").hide();
                $("#find").hide();
                $("#occasions").hide();
                $("#faq").hide();
                $("#hours").show();
          });
          
          $("#ticketstab").click(function(){
                $("#ttab").addClass('active');
                $("#htab").removeClass('active');
                $("#ftab").removeClass('active');
                $("#ocsntab").removeClass('active');
                $("#fqtab").removeClass('active');
                $("#hours").hide();
                $("#find").hide();
                $("#occasions").hide();
                $("#faq").hide();
                $("#tickets").show();
          });
          
          $("#findtab").click(function(){
                $("#ftab").addClass('active');
                $("#ttab").removeClass('active');
                $("#htab").removeClass('active');
                $("#ocsntab").removeClass('active');
                $("#fqtab").removeClass('active');
                $("#tickets").hide();
                $("#hours").hide();
                $("#occasions").hide();
                $("#faq").hide();
                $("#find").show();
          });
          
          $("#occsntab").click(function(){
                $("#ocsntab").addClass('active');
                $("#ttab").removeClass('active');
                $("#ftab").removeClass('active');
                $("#htab").removeClass('active');
                $("#fqtab").removeClass('active');
                $("#tickets").hide();
                $("#find").hide();
                $("#hours").hide();
                $("#faq").hide();
                $("#occasions").show();
          });
          
          $("#faqtab").click(function(){
                $("#fqtab").addClass('active');
                $("#ttab").removeClass('active');
                $("#ftab").removeClass('active');
                $("#ocsntab").removeClass('active');
                $("#htab").removeClass('active');
                $("#tickets").hide();
                $("#find").hide();
                $("#occasions").hide();
                $("#hours").hide();
                $("#faq").show();
          });
          
    /** end - for click on left menu tabs in plan your visit page **/
    
 
   
   $('.event-details-pop').mouseenter(function(){
   		var $this = $(this);
   		var popId = $this.attr('data-pop-id');
   		var containerWidth = $this.parents('.row:first').width();
   		if(popId=="1"){
   			$('.event-details-'+popId).css('left',(containerWidth*0.35)+"px").show();	
   		}else if(popId=="2"){
   			$('.event-details-'+popId).css('left',(containerWidth*-0.33)+"px").show();
   		}else if(popId=="3"){
   			$('.event-details-'+popId).css('left',(containerWidth*-0)+"px").show();
   		}
   	
   });
   
   $('.event-details-pop').mouseleave(function(){
   		var $this = $(this);
   		var popId = $this.attr('data-pop-id');
   		$('.event-details-'+popId).hide();
   	
   });
    
   /** login and savong data to cookies**/
   
   //$(document).on("click","#lgnbtn",function(){
        
   //                console.log("in submit login");
   //                var username = $("#login").find("#user").val();
   //                var password = $("#login").find("#password").val();
               
   //            $.each(user, function(a, b) {
   //             if (username === b.username || username === b.email) {
   //                 console.log(b.username);
   //                 console.log(b.password);
   //                 if (password === b.password) {
   //                   console.log("in password");
   //                     $.cookie("username", b.username,{path:'/'});
   //                     $.cookie("email", b.email,{path:'/'});
   //                     $.cookie("firstname", b.firstname,{path:'/'});
   //                     $.cookie("lastname", b.lastname,{path:'/'});
   //                     $.cookie("contact", b.contact,{path:'/'});
   //                     $("#login").modal("hide");
                        
   //                    /** setTimeout(function() {
   //                         window.location.href = window.location.origin + window.location.pathname;
   //                     }, 500);
   //                     removeOverlay();**/
   //                     $("#myaccount").show();
   //                     $("#loginlinks").hide();
   //                     name = $.cookie("username");
   //                     $("#username").html(name);
   //                     return;
   //                 } else {
   //                     alert("please enter the password correctly");
   //                 }
   //             }
   //         });
            
   //         if (!$.cookie("username")) {
   //             alert("Invalid username or password. Please try again.");
   //         }
            
   //         });
            
   //         $(document).on("click","#forgotPassword",function(){
            
   //             var fgt = prompt("Please enter the e-mail address of your account");
   //                 if (fgt) {
   //                     alert("The password is reset successfully and sent to you account e-mail.");
   //                 } else {
   //                     return;
   //                 }
   //         });
            
   //         $(document).on("click","#regBtn",function(){
            
   //             $("#login").modal("hide");
   //             $("a[data-target='#register']").trigger('click');
   //         });
            
            /** end of login and cookies **/
   
   
   //$(document).on("click","#registerBtn",function(){
        
                   
   //                console.log("in submit login");
   //                var regemail = $("#register").find("#email").val();
   //                var regpassword = $("#register").find("#regUsername").val();
   //                var regfirstname = $("#register").find("#regFirstname").val(); ;
   //                var reglastname = $("#register").find("#regLastname").val();;
   //                var regcontact = $("#register").find("#regcontact").val();;
   //                var regusername =$("#register").find("#regUsername").val();
   //                var regcpswd = $("#register").find("#regConfrimPass").val();
                   
   //                console.log(regcontact +" "+regemail+""+regfirstname+""+regusername+""+regcontact);
                    
   //                 if(regcpswd != regcpswd){
   //                     alert("Password and Confirm Password does not match.");
   //                     return;
   //                 }
   //                 alert("Your Registration is successful.Gift Card worth $50 has been sent to "+regemail);
   //                     $("#register").modal("hide");
   //                     $.cookie("username",regusername,{path:'/'});
   //                     $.cookie("email",regemail,{path:'/'});
   //                     $.cookie("firstname",regfirstname,{path:'/'});
   //                     $.cookie("lastname",reglastname,{path:'/'});
   //                     $.cookie("contact",regcontact,{path:'/'});
                        
   //                     $("#myaccount").show();
   //                     $("#loginlinks").hide();
   //                     name = $.cookie("username");
   //                     $("#username").html(name);
                        
   //                    });
   //$("#logout").click(function(){
   //             console.log("in logout");
   //             $.removeCookie('username',{path:'/'});
   //             $.removeCookie('email',{path:'/'});
   //             $.removeCookie('firstname',{path:'/'});
   //             $.removeCookie('lastname',{path:'/'});
   //             $.removeCookie('contact',{path:'/'});
           
   //             $("#myaccount").hide();
   //             $("#loginlinks").show();
   //             $("#username").html(" ");
   //         }); 
});








/** code for select a ticket tab **/

function entrypassprice(tickettype,qty){
    
    console.log("in entrypass price function");
    console.log("ticket:"+tickettype+" "+"qty:"+qty);
    dateofVisit = $('#datepicker').val();
    console.log("date"+dateofVisit);
      
    
    if(tickettype === 'adult'){
        adultqty = qty;
        adult = "true";
        subtotaladult = adultqty * adult_price;
        if(subtotaladult === 0.0){
            $('#subtotalone').html("--");
        }else{
            $('#subtotalone').html(subtotaladult);
        }
        
    }
    
        
    if(tickettype === 'child'){
        childqty = qty;
        child = "true";
        subtotalchild = childqty * child_price;
        if(subtotalchild === 0.0){
            $('#subtotalthree').html("--"); 
        }else{
            $('#subtotalthree').html(subtotalchild); 
        }
    }
    
}

function addShow(showType){
    showCount++;
    console.log("shwcnt"+showCount);
    if(showCount > 2){
        alert("You cannot add more than 2 shows per day.");
        return;
    }
    calculateCart(showType);
}

function calculateCart(checkTicket){
   
   $("html,body").scrollTop(1000);
   totalentryprice = subtotaladult + subtotalchild;
   
    if(totalentryprice === 0.0 ||  totalentryprice === undefined){
        alert("Please select your type of ticket to proceed!");
        return;
       }
        
        $("#next").show();
        if(checkTicket === "entry"){
            entryTicketAdded = "true";
            $("#cartitems").html("");
            $(".totalpricerow").remove();
            
            $("#cartitems").append("<tr>"+
                    "<td>"+"Entry Ticket Price"+"</td>"+
                    "<td>"+"<span>$</span>"+totalentryprice+"</td>"+
                    "<td>"+"<button class='btn btn-default btn-xs rementryPrice'>Remove</button>"+"</td>"+
                    "</tr>");
            $("#cartitems").append("<tr class='discountpricerow'>"+"<td  colspan='2'>"+"Discount:"+"</td>"+
                    "<td>"+"<span>$</span>"+discountPrice+"</td>"+"</tr>");
            $("#cartitems").append("<tr class='totalpricerow'>"+"<td colspan='2'>"+"Total:"+"</td>"+
                    "<td>"+"<span>$</span>"+totalentryprice+"</td>"+"</tr>");
    }
    if(checkTicket !== "entry"){
        showAdded = "true";
        if(entryTicketAdded !== "true"){
            alert("Please Add an Entry Ticket before adding Shows!");
            return;
        }
        if(showCount === 2){
            discount="true";
            alert("You have got a discount of 30% on adding 2 shows .");
            
        }
        showprice = 0.0;
        
        
        if(checkTicket === "dolphin"){
            showname = "Dolphin Show";
            $(".dolphinButton").prop('disabled',true);
            
                if(adult === "true"){
                    p_dolphinshow += adultqty * adult_price_show;
                 }

                if(child === "true"){
                    p_dolphinshow += childqty * child_price_show;
                }
             showprice = p_dolphinshow;   
             shows.push(showname)
             showPrices.push(p_dolphinshow);
        }else if(checkTicket === "music"){
            showname = "Music Show";
            $(".musicButton").prop('disabled',true);
            
                if(adult === "true"){
                        p_musicshow += adultqty * adult_price_show;
                     }

                    if(child === "true"){
                        p_musicshow += childqty * child_price_show;
                    }
                showprice = p_musicshow;
                shows.push(showname);
                showPrices.push(p_musicshow);
                
        }else if(checkTicket === "coral"){
                showname = "Coral Show";
                $(".coralButton").prop('disabled',true);

                if(adult === "true"){
                        p_coralshow += adultqty * adult_price_show;
                     }

                    if(child === "true"){
                        p_coralshow += childqty * child_price_show;
                    }
                showprice = p_coralshow;
                shows.push(showname);
                showPrices.push(p_coralshow);
        }
       
        
        totalshowprice += showprice;
        if(showCount === 2){
            discountPrice = ((0.3)*totalshowprice);
            discountshowprice = (totalshowprice) - discountPrice;
            totalprice = totalentryprice + discountshowprice;
        }else{
            totalprice = totalentryprice + totalshowprice;
        }
         
        $(".discountpricerow").remove();
         $("#cartitems").append("<tr>"+
                    "<td class='c_showname'>"+showname+"</td>"+
                    "<td>"+"<span>$</span>"+showprice+"</td>"+
                    "<td>"+"<button class='btn btn-default btn-xs remshow' >Remove</button>"+"</td>"+"</tr>");
           $(".totalpricerow").remove();
           $("#cartitems").append("<tr class='discountpricerow'>"+"<td  colspan='2'>"+"Discount Price"+"</td>"+
                    "<td>"+"<span>$</span>"+discountPrice+"</td>"+"</tr>");
           $("#cartitems").append("<tr class='totalpricerow'>"+"<td colspan='2'>"+"Total Price"+"</td>"+
                    "<td>"+"<span>$</span>"+totalprice+"</td>"+"</tr>");
    }
    
}


$(document).on("click",".rementryPrice",function(){
    console.log("in remove entry");
    if(showAdded == "true"){
        alert("Shows added to the cart will also be removed.");
        
    }
   $("#cartitems").html(""); 
   $("#cartitems").append("<tr>"+
                    "<td colspan='3'>"+"There are no tickets currently added to your cart"+"</td>"+
                    "</tr>");
   $("#cartitems").append("<tr>"+
                    "<td colspan='2'>"+"Total"+"</td>"+
                    "<td>"+"<span>$</span>"+"0.0"+"</td>"+
                    "</tr>");
});

$(document).on("click",".remshow",function(){
    showCount--;
    if(showCount == 0){
        showAdded = "false";
    }
    discountPrice = 0.0;
    console.log("in remove show");
    var showremoved = $(this).parents('tr:first').find('.c_showname').text();
    console.log("showname:"+$(this).parents('tr:first').find('.c_showname').text());
    
    if(showremoved == "Dolphin Show"){
        shows.pop("Dolphin Show");
      $(".dolphinButton").prop('disabled',false);
        totalshowprice -= p_dolphinshow;
    }
    
    if(showremoved == "Coral Show"){
        shows.pop("Coral Show");
        $(".coralButton").prop('disabled',false);
        totalshowprice -= p_coralshow;
    }
    
    if(showremoved == "Music Show"){
        shows.pop("Music Show");
       $(".musicButton").prop('disabled',false); 
       totalshowprice -= p_musicshow;
    }
    
    $(this).parents('tr:first').remove();
    
    $(".discountpricerow").remove();
    $(".totalpricerow").remove();
    totalprice = totalentryprice + totalshowprice;
    $("#cartitems").append("<tr class='discountpricerow'>"+"<td  colspan='2'>"+"Discount:"+"</td>"+
                    "<td>"+"<span>$</span>"+discountPrice+"</td>"+"</tr>");
            $("#cartitems").append("<tr class='totalpricerow'>"+"<td colspan='2'>"+"Total:"+"</td>"+
                    "<td>"+"<span>$</span>"+totalprice+"</td>"+"</tr>");
       
});

/** end of code for select a ticket tab **/

function showTicket(){
    
    $("#facilitiesli").removeClass('active');
    $("#ticketsli").addClass('active');
    $("#type").show();
    $("#facilities").hide();
}

function showFacilities(){
    
    $("#ticketsli").removeClass('active');
    $("#facilitiesli").addClass('active');
    $("#type").hide();
    $("#facilities").show();
    
    if(userName !== "null"){
        firstname = $.cookie("firstname");
        lastname = $.cookie("lastname");
        email = $.cookie("email");
        contact = $.cookie("contact");
        $("#fn").val(firstname);
        $("#ln").val(lastname);
        $("#mob").val(email);
        $("#email").val(contact);
}
    
};

function mealPlan(){
    //alert("in meal plan"+$("#lunch").is(":checked"));
    guide = $(":radio[name = guide]:checked").val();
    if($("#lunch").is(":checked")){
        lunchplan = "yes";
        mealqty = $("#mealqty").val();
        if(mealqty == 0){
            alert("Please select quantity");
            
            return;
        }
        alert("Your Lunch Reservation for "+mealqty +" is added to your order.");
        return;
    }else{
        lunchplan = "no";
        alert("Your Lunch Reservation is cancelled by you.");
        $("#mealqty").val('0');
        return;
    }
   
}

function ridePlan(){
    $("html,body").scrollTop(1500);
    if($("#ride").is(":checked")){
        ridePlans = "yes";
        rideqty = $("#rideqty").val();
        if(rideqty == 0){
            alert("Please select quantity");
            return;
        }
        ridePrice = rideqty * ridePrice;
        totalprice += ridePrice;
        console.log("total price in facilities"+totalprice);
       $("#ridePrice").html("You have chosen for a ride with sea animals for "+rideqty+" adults.Your Order Total is: $"+totalprice);
       //$("#orderTotal").html("Your Order Total is: $"+totalprice);
       
    }else{
        totalprice -= ridePrice;
        ridePrice = 30;
        ridePlans = "no"
        $("#rideqty").val('0');
        $("#ridePrice").html("Your Order for Ride with Sea animals is cancelled by you.Odrer Total is: $"+totalprice);
    }
}

function showPayment(redirection){
    
    if($("#fn").val() === "" || $("#fn").val() === undefined){
        alert("Please enter Your First Name");
        return;
    }
    
    if($("#ln").val() === "" || $("#ln").val() === undefined){
        alert("Please enter Your Last Name Name");
        return;
    }
    
    if($("#email").val() === "" || $("#email").val() === undefined){
        alert("Please enter Your Email");
        return;
    }
    
    if($("#mob").val() === "" || $("#mob").val() === undefined){
        alert("Please enter Your Contact No.");
        return;
    }
    
        if(userName == "null" || userName == undefined){
                firstname = $("#fn").val();
                lastname = $("#ln").val();
                email = $("#email").val();
                contact = $("#mob").val();
         }
   
    $("#paymentli").addClass('active');
    $("#type").hide();
    $("#facilities").hide();
    $("#payment").show();
    
    if(adult == "true" && child == "true"){
        entryTicketDescription = "Your Entry Ticket Price for" +adultqty + " Adult(s) and "+childqty+" Child(s)";
    }
    else if(adult == "true"){
        entryTicketDescription = "Your Entry Ticket for" +adultqty + " Adult(s)";
    }
    else if(child == "true"){
       entryTicketDescription = "Your Entry Ticket for " +childqty + "Child(s)"; 
    }
    
    
    $("#previewcart").append("<tr>"+"<td>"+entryTicketDescription+"</td>"+
            "<td>"+totalentryprice+"</td>"+"</tr>");
    
    if(showAdded !== "false"){
    for(i = 0;i < showCount;i++){
    $("#previewcart").append("<tr>"+
                    "<td>"+shows[i]+"</td>"+
                    
                    "<td>"+showPrices[i]+"</td>"+"</tr>");
    }
   
}
    if(guide == "yes"){
        $("#previewcart").append("<tr>"+"<td>"+"Guide Needed:"+"</td>"+
                    "<td>"+"Yes"+"</td>"+"</tr>");
    }
    
    if(lunchplan == "yes"){
        $("#previewcart").append("<tr>"+"<td>"+"Lunch Reservation for "+mealqty+"</td>"+
                    "<td>"+"Reserved"+"</td>"+"</tr>");
    }
    
    if(ridePlans == "yes"){
        $("#previewcart").append("<tr>"+"<td>"+"Ride with Sea Animals for "+rideqty+"</td>"+
                    "<td>"+"<span>$</span>"+ridePrice+"</td>"+"</tr>");
    }
    
    $("#previewcart").append("<tr>"+"<td>"+"OrderTotal:"+"</td>"+
                    "<td>"+totalprice+"</td>"+"</tr>");
}

function showConfirm(){
    console.log("in confirm");
    
    console.log("checkbox val"+$("#agree").val());
    
    if($("#cardtype").val() === "none"){
        alert("Please enter Card Type");
        return;
    }
    
    if($("#cardno").val() === "" || $("#cardno").val() === undefined){
        alert("Please enter 16 digit Card Number");
        return;
    }
    
    if($("#month").val() === "none"){
        alert("Please select month");
        return;
    }
    
    if($("#year").val() === "none"){
        alert("Please select year");
        return;
    }
    
    if($("#sec").val() === "" || $("#sec").val() === undefined){
        alert("Please enter 3 Digit security code");
        return;
    }
    
    if(!($("#agree").is(":checked"))){
        alert("Please read terms and conditionds and click on I agree before you confirm");
        return;
    }
    
    $("#confirmli").addClass('active');
    $("#type").hide();
    $("#facilities").hide();
    $("#payment").hide();
    $("#confirm").show();
    ticketId = Math.round(Math.random() + 9);
    
    refDetails1 = "Congratulations "+firstname+"!.Your order is processed successfully";
    refDetails2 = "Your Ticket Id is "+ticketId+".An email has been seen to "+email+" and a message has been sent to your registered mobile no.";
    $("#reference").html(refDetails1);
    $("#refId").html(refDetails2);
    
    $("#orderTable").append("<tr>"+"<td>"+"Ticket Confirmation Id "+"</td>"+
                    "<td>"+ticketId+"</td>"+"</tr>");
    
    $("#orderTable").append("<tr>"+"<td>"+"Date Of Visit "+"</td>"+
                    "<td>"+dateofVisit+"</td>"+"</tr>");
            
    $("#orderTable").append("<tr>"+"<td>"+entryTicketDescription +"</td>"+
                    "<td>"+"<span>"+"$"+"</span>"+totalentryprice+"</td>"+"</tr>");
    
    $("#orderTable").append("<tr>"+"<td colspan='2'>"+"You ordered for "+showCount+" Show(s) "+"</td>"+
                    "</tr>");
            
    for(i = 1;i <= showCount ; i++){
        $("#orderTable").append("<tr>"+"<td>"+shows[i]+" Price"+"</td>"+
                    "<td>"+"<span>"+"$"+"</span>"+showPrices[i]+"</td>"+"</tr>");
        $("#orderTable").append("<tr>"+"<td>"+shows[i]+" Timings"+"Price"+"</td>"+
                    "<td>"+"<span>"+"$"+"</span>"+""+"</td>"+"</tr>");
    }
    
    $("#orderTable").append("<tr>"+"<td>"+"Your Order Total "+"</td>"+
                    "<td>"+"<span>"+"$"+"</span>"+totalprice+"</td>"+"</tr>");
            
            
    $("#personaldetails").append("<tr>"+"<td>"+"First name"+"</td>"+
                    "<td>"+firstname+"</td>"+"</tr>");
            
    $("#personaldetails").append("<tr>"+"<td>"+"Last name"+"</td>"+
                    "<td>"+lastname+"</td>"+"</tr>");
    $("#personaldetails").append("<tr>"+"<td>"+"Email Id"+"</td>"+
                    "<td>"+email+"</td>"+"</tr>");
    $("#personaldetails").append("<tr>"+"<td>"+"Contact"+"</td>"+
                    "<td>"+contact+"</td>"+"</tr>");
            
}

