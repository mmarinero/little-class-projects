function lyricSearch(i) 
{
    var tabla = document.getElementById("trackList");
    var columna = tabla.rows[i+1].cells;
    peticion(columna[1].firstChild.innerHTML , columna[2].firstChild.innerHTML, columna[5]);
}
function peticion (cancion, artista, celda) 
{
    if (window.XMLHttpRequest)
    {// code for IE7+, Firefox, Chrome, Opera, Safari
        xmlhttp=new XMLHttpRequest();
    }
    else
    {// code for IE6, IE5
        xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
    }
    xmlhttp.onreadystatechange = function () 
    {
        if (xmlhttp.readyState==4)
            if (xmlhttp.status==200)
            {
                celda.innerHTML = xmlhttp.responseText;
            }
    }
    celda.innerHTML = "buscando...";
    xmlhttp.open("GET","default.aspx?s="+cancion+"&a="+artista,true);
    xmlhttp.send(null);
}