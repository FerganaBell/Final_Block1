# Итоговая работа 
## Блок "Разработчик.Основной"

### Объяснение кода программы:

1. **Ввод массива с клавиатуры:** Программа предлагает пользователю ввести элементы массива, разделенные пробелами. Полученная строка разбивается на массив строк с помощью метода `Split(' ')`.

2. **Подсчет подходящих строк:** Определяется количество строк, длина которых меньше или равна 3 символам, чтобы создать новый массив нужного размера.

3. **Создание нового массива:** Создается новый массив, и в него добавляются только те строки, которые соответствуют заданному условию.

4. **Вывод результата:** Результирующий массив выводится в одну строку, разделяя элементы пробелом, используя метод `string.Join(" ", resultArray)`.

*Этот код позволяет пользователю вводить массив строк и получаmь на выходе новый массив с элементами, длина которых меньше или равна 3 символам, все в одной строке через пробел.*
