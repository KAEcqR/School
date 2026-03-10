import kotlin.random.Random

fun main() {
    generateRandomNumbers(10, 1, 100)
}

fun generateRandomNumbers(count:Int, min:Int,max:Int):Int {
    val random = Random
    var sum = 0
    for (i in 1..count) {
        val number = random.nextInt(min,max+1)
        sum += number
    }
}