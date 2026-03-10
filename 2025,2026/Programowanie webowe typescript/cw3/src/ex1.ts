function fun1(): void {
    const a: number = 5;
    console.log(`typ zmiennej a to ${typeof a} a = ${a}`);
}
function Repeater(a: number, text: string): void {
    for (let i = 0; i < a; i++) {
        console.log(text);
    }
}
fun1();
Repeater(3, "Ala ma kota");
