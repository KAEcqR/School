

function User(firstname,lastname,email) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.email = email; 
}

function GetUser(){
    const firstname = document.querySelector("#firstname").value
    const lastname = document.querySelector("#lastname").value
    const email = document.querySelector("#email").value

    //todo walidacja
    const user = new User(firstname, lastname, email)
    return user 
}


function AddRow(user, table){

    const row = table.insertRow();
    const c0 = row.insertCell(0)
    const c1 = row.insertCell(1)
    const c2 = row.insertCell(2)
    const c3 = row.insertCell(3)
    c0.innerHTML = user.firstname
    c1.innerHTML = user.lastname
    c2.innerHTML = user.email

    const img = document.createElement("img")
    img.id = "GGG" //todo sprawdzam czy sie wyswietla
    img.src = "img/Delete.png"
    img.style.cursor = "pointer"

    c3.appendChild(img)
    generOnClick(img, table)
    clear()
}

document.querySelector("#insert").addEventListener("click", () => {
    const user = GetUser();
    const table = document.querySelector("#table")
    AddRow(user, table)
})

function generOnClick(img, table){
    img.addEventListener("click", () => {
        const parentRow = img.parentElement.parentElement
        console.log(parentRow)
        table.deleteRow(parentRow.rowIndex)
    })
}

function clear (){
    const firstname = document.querySelector("#firstname").value = ""
    const lastname = document.querySelector("#lastname").value = ""
    const email = document.querySelector("#email").value = ""
}