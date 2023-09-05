class User{
    constructor(login,firstname, lastname,createDate,description){
        this.login = login
        this.firstname = firstname
        this.lastname = lastname
        this.createDate = createDate
        this.description = description
    }
    
    userToTableRow(){
        return `<tr>
        <td>${this.login}</td>
        <td>${this.firstname}</td>
        <td>${this.lastname}</td>
        <td>${this.createDate}</td>
        <td>${this.description}</td>
        </tr>`
    }
}

const users = [
    new User("antoni","Antoni","Nowak",new Date(2012,2,12).toLocaleDateString(),"Opis antusia"),
    new User("renia","Renata","Małecka"),
    new User("tomcio","Tomasz","Uczesany",new Date(2001,9,11).toLocaleDateString(),"Piękny fryz"),
    new User("mlizard","Gucio","Bodzio"),
]

function createTable(elem){
    $(elem).append(`
    <table id="users" class="table" table-stripped">
        <tr>
            <th>Login</th>
            <th>Imie</th>
            <th>Nazwisko</th>
            <th>Data</th>
            <th>Opis</th>
        </tr>
    </table>`

    data.forEach(element => {
        $("#users tr:last").after(element.userToTableRow())
    })
    )
}

createTable($("#root"))
