// Funkcja do odczytu pliku dane.txt
async function readFile(): Promise<void> {
    try {
        // Wczytanie pliku dane.txt z serwera lub folderu public
        const response = await fetch('dane.txt'); // Zakładając, że dane.txt jest w folderze public
        if (!response.ok) {
            throw new Error('Nie udało się wczytać pliku dane.txt');
        }

        const fileContent = await response.text(); // Odczytujemy plik jako tekst
        // Wstawiamy zawartość do textarea
        const fileContentTextarea = document.getElementById('fileContent') as HTMLTextAreaElement;
        fileContentTextarea.value = fileContent;

        // Ustawiamy początkową zawartość do edytowania w drugim textarea
        const newContentTextarea = document.getElementById('newContent') as HTMLTextAreaElement;
        newContentTextarea.value = fileContent;
    } catch (error) {
        console.error(error);
    }
}

// Funkcja do zapisania nowego pliku
function saveFile(content: string): void {
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
const saveButton = document.getElementById('saveButton') as HTMLButtonElement;
saveButton.addEventListener('click', () => {
    const newContentTextarea = document.getElementById('newContent') as HTMLTextAreaElement;
    const newContent = newContentTextarea.value;
    saveFile(newContent);
});
