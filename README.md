# Kontrolnaya_rabota_GB_poisk_v_massive
### Kонтрольная работа по поиску в массиве

Программа предназначена для вывода названий рок-групп, состояших из трех и менее букв

Написана на языке C#



1. **Метод `Main`**:
   - Этот метод является точкой входа в программу. Он принимает массив строк `args` в качестве аргумента (хотя в данном случае не используется).
   - В методе `Main` определен начальный массив строк `initialArray`, содержащий названия рок-групп и исполнителей.
   - Вызывается метод `PrintArray(initialArray)`, который выводит начальный массив `initialArray` в консоль.
   - Затем вызывается метод `FilterArray`, чтобы получить новый массив строк, содержащий только те элементы из начального массива, длина которых не превышает три символа.
   - После этого вызывается метод `PrintArray(newArray)`, чтобы вывести полученный отфильтрованный массив в консоль.

2. **Метод `FilterArray`**:
   - Этот метод принимает на вход исходный массив строк `array`.
   - Вначале метод перебирает каждую строку из `array`, подсчитывая количество строк, длина которых не превышает три символа.
   - Затем создается новый массив `result` нужного размера, равного количеству строк, удовлетворяющих условию.
   - Второй проход по исходному массиву заполняет новый массив `result` отфильтрованными строками.
   - Новый массив `result` возвращается в вызывающий код.

3. **Метод `PrintArray`**:
   - Этот метод принимает массив строк `array`.
   - Он просто перебирает каждую строку из массива и выводит ее в консоль.

В результате выполнения этой программы в консоль будет выведен исходный массив строк `initialArray`, а затем отфильтрованный массив строк, содержащий только те строки, длина которых не превышает три символа.