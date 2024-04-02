<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/css/bootstrap.min.css" integrity="sha512-b2QcS5SsA8tZodcDtGRELiGv5SaKSk1vDHDaQRda0htPYWZ6046lr3kJ5bAAQdpV2mmA/4v0wQF9MyU6/pDIAg==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.2/js/bootstrap.bundle.min.js" integrity="sha512-X/YkDZyjTf4wyc2Vy16YGCPHwAY8rZJY+POgokZjQB2mhIRFJCckEGc6YyX9eNsPfn0PzThEuNs+uaomE5CO6A==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    
</head>
<body>
    <?php
        require_once "functions.php";
    ?>
    <div class="container">
        <h1>Dane Osobowe</h1>
        <form method="post">
            <div class="row m-2">
                <label for="firstname" class="col-3">Podaj imie</label>
                <input class="col-6" type="text" name="firstname" id="firstname">
            </div>
            <div class="row m-2">
                <label for="lastname" class="col-3">Podaj nazwisko</label>
                <input class="col-6" type="text" name="lastname" id="lastname">
            </div>
            <div class="row m-2">
            <label for="divisions" class="col-3"> Wybierz Klase</label>
                <?php
                echo DivisionToSelect(GetDivision());
                ?>
            </div>
            <div class="row m-2">
            <label for="gender" class="col-3"> Wybierz Plec</label>
                <div class="col-3">
                    <label><input class="p-2" type="radio" value="K" name="gender"> Kobieta </input></label>
                    <label><input class="p-2" type="radio" value="M" name="gender"> Menszczysna </input></label>
                </div>
            </div>
            <div class="row m-2">
            <label for="divisions" class="col-3"> Wybierz Hobby</label>
                <?php
                echo HobbyToCheckBox(GetHobby());
                ?>
            </div>
            <input type="submit" value="Submit" name ="submit" class="btn btn-primary btn-lg btn-block">
        </form>
    </div>

    <?php
    echo Wyswietl();
    ?>
</body>
</html>