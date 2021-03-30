

function changeLink() {
    let active_link = document.getElementById("current_cat").innerHTML;
    let link_key = "link-" + active_link

    document.getElementById(link_key).style.backgroundColor = "rgba(171, 183, 183, 0.9)";

   

}


changeLink()