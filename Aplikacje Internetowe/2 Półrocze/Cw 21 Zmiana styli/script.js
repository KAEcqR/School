let first = document.querySelector("#first")
let second = document.querySelector("#second")

let choice1 = document.getElementById("choice1");
choice1.addEventListener("change", function() {
  first.className = ``
  let text = choice1.options[choice1.selectedIndex].text;
  console.log(text);
  first.classList.add(`${text}`)
});

let AllCheckbox = document.querySelectorAll("input[type=checkbox]")

AllCheckbox.forEach((e) => {
    e.addEventListener("change", function() {
        if (e.checked) {
            second.classList.add(`${e.id}`)
        } else {
            second.classList.remove(`${e.id}`)
        }
      });
})
