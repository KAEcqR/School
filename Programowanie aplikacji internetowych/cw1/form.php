<!-- form.php -->

<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formularz</title>
    <style>
        .form-container {
            max-width: 600px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 5px;
        }
        .form-container label {
            display: block;
            margin: 10px 0 5px;
        }
        .form-container input {
            width: 100%;
            padding: 8px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .form-container button {
            padding: 10px 20px;
            font-size: 16px;
            color: #fff;
            background-color: #007bff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .form-container button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <div class="form-container">
        <h1>Formularz</h1>
        <form action="submit.php" method="POST">
            <label for="year">Rok:</label>
            <input type="number" id="year" name="year" required>

            <label for="title">Tytuł:</label>
            <input type="text" id="title" name="title" required>

            <label for="author">Autor:</label>
            <input type="text" id="author" name="author" required>

            <label for="price">Cena:</label>
            <input type="number" id="price" name="price" step="0.01" required>

            <button type="submit">Wyślij</button>
        </form>
    </div>
</body>
</html>
