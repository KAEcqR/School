//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
fun main() {
    val name = "Kotlin"
    showEvenNumbers(10);
    showEvenNumbersRange(5, 10)
    //TIP Press <shortcut actionId="ShowIntentionActions"/> with your caret at the highlighted text
    // to see how IntelliJ IDEA suggests fixing it.

//    println("Hello, " + name + "!")
//
//    var age = 10
//    println("age : " + age)
//    age = 15
//    println("age : " + age)
//
//    for (i in 1..5) {
//        //TIP Press <shortcut actionId="Debug"/> to start debugging your code. We have set one <icon src="AllIcons.Debugger.Db_set_breakpoint"/> breakpoint
//        // for you, but you can always add more by pressing <shortcut actionId="ToggleLineBreakpoint"/>.
//        println("i = $i")
//    }
}

fun showEvenNumbers(max: Int) {
    var counter = 0;
    var i = 1;
    while (counter <= max) {
        if( i % 2 == 0) {
            println("$i");
            counter++;
        }
        i++;
    }
}

fun showEvenNumbersRange(min: Int, max: Int) {
    for (i in min..max) {
        if(i % 2 == 0) {
            println("$i");
        }
    }
}