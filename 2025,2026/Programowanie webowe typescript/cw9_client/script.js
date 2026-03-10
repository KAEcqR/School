async function loadStudents() {
    const res = await fetch("http://localhost:3001/");
    const data = await res.json();

    const tbody = document.querySelector("#studentsTable tbody");
    tbody.innerHTML = "";

    data.forEach(student => {
        const row = document.createElement("tr");

        row.innerHTML = `
            <td>${student.id}</td>
            <td>${student.firstname}</td>
            <td>${student.lastname}</td>
            <td>${student.birthDate}</td>
            <td><button class="btn btn-danger delete-btn" data-id="${student.id}">Usuń</button></td>
        `;

        tbody.appendChild(row);
    });

    document.querySelectorAll(".delete-btn").forEach(btn => {
        btn.addEventListener("click", async (e) => {
            const id = e.target.dataset.id;

            await fetch(`http://localhost:3001/${id}`, {
                method: "DELETE"
            });

            loadStudents();
        });
    });
}

loadStudents();
