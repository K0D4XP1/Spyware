
<html>
    <head>
        <title></title>
    </head>
    <body>
        PAINEL DE MALWARES
        <hr>
        <?php
            $lista = file_get_contents("clients.txt");
            echo $lista;
        ?>
    </body>
</html>
