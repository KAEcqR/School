function validateForm() {
    let x = document.forms["formularz"]["wiek"].value;
    if (x < 18) {
      alert("Jesteś za młody, aby wysłać formularz");
      return false;
    }
}