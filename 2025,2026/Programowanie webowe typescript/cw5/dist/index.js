// Funkcja do odczytu pliku dane.txt
async function readFile() {
    try {
        // Wczytanie pliku dane.txt z serwera lub folderu public
        const response = await fetch('dane.txt'); // Zakładając, że dane.txt jest w folderze public
        if (!response.ok) {
            throw new Error('Nie udało się wczytać pliku dane.txt');
        }
        const fileContent = await response.text(); // Odczytujemy plik jako tekst
        // Wstawiamy zawartość do textarea
        const fileContentTextarea = document.getElementById('fileContent');
        fileContentTextarea.value = fileContent;
        // Ustawiamy początkową zawartość do edytowania w drugim textarea
        const newContentTextarea = document.getElementById('newContent');
        newContentTextarea.value = fileContent;
    }
    catch (error) {
        console.error(error);
    }
}
// Funkcja do zapisania nowego pliku
function saveFile(content) {
    const blob = new Blob([content], { type: 'text/plain' });
    const link = document.createElement('a');
    link.href = URL.createObjectURL(blob);
    link.download = 'nowy_plik.txt';
    link.click();
}
// Wywołujemy funkcję do wczytania pliku po załadowaniu strony
window.onload = () => {
    readFile(); // Wczytujemy plik dane.txt
};
// Obsługuje zapis pliku
const saveButton = document.getElementById('saveButton');
saveButton.addEventListener('click', () => {
    const newContentTextarea = document.getElementById('newContent');
    const newContent = newContentTextarea.value;
    saveFile(newContent);
});
export {};
//# sourceMappingURL=index.js.map