import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;

public class SearchWay {
    public static void SearchWays(int[][] arr) {
        Queue<Integer> que = new LinkedList<>();
        LinkedList<Integer> link = new LinkedList<>();
        String msg = "";
        int x = 0;
        int y = 0;
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr.length; j++) {
                switch (arr[i][j]){
                    case 1:
                        que.add(i);
                        que.add(j);
                        System.out.println(que);
                        link.add(que.element());
                        que.remove();
                        link.add(que.element());
                        que.remove();
                        System.out.println(que);
                        System.out.println(link);
                        break;
                    case 2:
                        que.add(i);
                        que.add(j);
                        System.out.println(que);
                        link.add(que.element());
                        que.remove();
                        link.add(que.element());
                        que.remove();
                        System.out.println(que);
                        System.out.println(link);
                        break;
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:


                        break;


                }
            }
        }

    }
}

