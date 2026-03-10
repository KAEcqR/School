import './style.css'
import { colors } from './data'

const appDiv: HTMLDivElement = document.createElement("div");
appDiv.textContent = "test";

const ulElement: HTMLUListElement = document.createElement("ul");
for (const c of colors) {
  const liElement: HTMLLIElement = document.createElement("li");
  liElement.textContent = c;
  ulElement.appendChild(liElement);
}

const selectElement: HTMLSelectElement = document.createElement("select");
selectElement.className = "scena";
for (const c of colors) {
  const optionElement: HTMLOptionElement = document.createElement("option");
  optionElement.textContent = c;
  optionElement.value = c;
  selectElement.appendChild(optionElement);
}

selectElement.addEventListener("change", (e) => {
  if (e.target) {
    selectElement.style.backgroundColor = selectElement.value;
  }
});

const rootDiv: HTMLElement | null = document.querySelector<HTMLElement>("#app");
if (rootDiv) {
  rootDiv.appendChild(appDiv);
  rootDiv.appendChild(ulElement);
  rootDiv.appendChild(selectElement);
}