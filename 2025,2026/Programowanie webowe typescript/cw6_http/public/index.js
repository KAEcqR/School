const contacts = [
            { name: "Alice", phone: "123-456-7890" },
            { name: "Bob", phone: "987-654-3210" },
            { name: "Charlie", phone: "555-555-5555" }
        ];
        const select = document.createElement('select');
        select.id = 'contactSelect';
        for (const c of contacts) {
            const option = document.createElement('option');
            option.value = c.phone;
            option.textContent = `${c.name} (${c.phone})`;//innnText, innerHTML, textContent
            select.appendChild(option);
        }
        document.getElementById('result').appendChild(select);