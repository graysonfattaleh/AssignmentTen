

function changeLink() {
    let active_link = document.getElementById("current_cat").innerHTML;
    let link_key = "link-" + active_link

    document.getElementById(link_key).style.color = "red";

    hot_link.style.color = "red";

}


changeLink()