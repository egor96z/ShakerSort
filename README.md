# Реализация алгоритма сортировки "Шейкерная сортировка"
Данный проект представляет собой реализацию популярного алгоритма быстрой сортировки. Проект состоит из трёх частей:

- Проект ShakerSort, в котором находится класс ShakerSorter с реализацией алгоритма,
метод public void Sort(int[] myint) принимает массив целых чисел и сортирует его по возра-
станию значений. 
Пример использования:

// создаём экземпляр сортировщика
ShakerSorter sorter = new ShakerSorter();
sorter.Sort(array); // array -- целочисленный массив

- В проекте ShakerSort.Usage приведёна демонстрация использования алгоритма с вводом-выводом
массива на консоль.
- В проекте ShakerSort.Tests реализованы тесты.

Класс ShakerSort работает только с целочисленными массивами (int[]).
Выбрасывает исключение ArgumentNullException, если переданный ему массив имел значение null.
