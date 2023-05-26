class User{

    constructor(login,firstname,lastname,createDate = new Date().toLocaleDateString(),
    description =''){
        this.login = login;
        this.firstname = firstname;
        this.lastname = lastname;
        this.createDate = createDate;
        this.description = description;
    }
    userToTableRow(){
        return `<tr>
        <td>${this.login}</td>
        <td>${this.firstname}</td>
        <td>${this.lastname}</td>
        <td>${this.createDate}</td>
        <td>${this.description}</td>
        </tr>`;
    }
}
const users = [
    new User("antoni","Antoni","Nowak",new Date(2012,2,12).toLocaleDateString(),"fajny lolo"),
    new User("renia","Renata","Małecka"),
    new User("tomcio","Tomasz","Bomasz",new Date(2019,2,12).toLocaleDateString(),"tomcio paluch"),
    new User("roman","Roman","Tymacka"),
    new User("henryk","Henryk","Tymacka"),
    new User("eleonora","Eleonora","Tymacka",new Date(2021,8,12).toLocaleDateString()),
    new User("antoni","Antoni","Tymacka",new Date(2021,5,21).toLocaleDateString(),"gh fhfhfhfhfh fg "),
]
function createTable(elem,data){
    $(elem).append(`<table id='users' class="table table-striped">
    <tr>
        <th>Login</th>
        <th>Imię</th>
        <th>Nazwisko</th>
        <th>Data utworzenia</th>
        <th>Opis</th>
    </tr>
    </table>`);
   // console.log(data);
    data.forEach(element => {
       // console.log(element.userToTableRow());
       // console.log($("#users tr:last"));
        $("#users tr:last").after(element.userToTableRow());
    });
    
}
createTable($("#root"),users);
$("#find").on("input",(event)=>{
    console.log(event.target.value);
    const result = users.filter((elem)=>{
        return elem.login.toLowerCase().includes(event.target.value.toLowerCase());
    })
    $("#root").html("");
    createTable($("#root"),result)
    console.log(result);
});