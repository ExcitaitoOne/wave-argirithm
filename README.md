# wave-argirithm

## Реализация волнового алгоритма

1. Генератор карт
  + 1.1 статическая

-1 -1 -1 -1 -1 -1
-1 -2 0 0 0 -1
-1 -1 -1 -1 0 -1
-1 0 0 0 0 -1
-1 1 0 0 0 -1
-1 -1 -1 -1 -1 -1


int[][] generateMap (int width, int height)
+ 1.2 автогенерация карт
+ 1.3 загрузка карт из файла

2. Печать карты в "сыром" виде
+ 2.1 терминал
String printMap(int[][])
+ 2.2 принтер
+ 2.3 сторонний сервис (api)

3. Печать карты в красиво


4. Раскраска карты
void colorize(int[][] map)
+ 4.1 установка котика
+ 4.2 выходы

5. Поиск выхода
