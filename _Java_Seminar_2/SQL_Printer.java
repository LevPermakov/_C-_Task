package Seminar_2;

import java.util.Map;
import java.io.*;

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class SQL_Printer {
    public static void main(String[] args) {
        String QUERY = "";
        String PARAMS = "";

        if (args.length == 0) {
            // При отправке кода на Выполнение, вы можете варьировать эти параметры
            QUERY = "select * from students where ";
            // json с параметрами
            PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
            // PARAMS = "{\"name\":\"null\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
        } else {
            QUERY = args[0];
            PARAMS = args[1];
        }

        Answer ans = new Answer();
        System.out.println(ans.answer(QUERY, PARAMS));
    }
}

class Answer {
    /**
     * @param QUERY
     * @param PARAMS
     * @return
     */
    public static StringBuilder answer(String QUERY, String PARAMS) {

        // Напишите свое решение ниже
        // создаем экземпляр StringBuilder для формирования запроса
        StringBuilder sBuilder = new StringBuilder();
        // {"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}
        // Подсказка № 1
        // Символ "\" в строке параметров фильтрации (PARAMS) является экранирующим для кавычек, 
        // поэтому при парсинге его можно игнорировать.
        String nPARAMS = PARAMS.replaceAll(" ",  "");
        String nnPARAMS = nPARAMS.replaceAll("\"",  "");
        String nnnPARAMS = nnPARAMS.replaceAll("\\{",  "");
        String newPARAMS = nnnPARAMS.replaceAll("\\}",  "");

        // System.out.println(PARAMS);
        // System.out.println(newPARAMS);
        //int lParms = newPARAMS.length();
        // System.out.println(lParms);

        String[][] slovar = new String[20][2];

        String[] keyVars = newPARAMS.split("[:,]");
        // System.out.println(words);
        // for (String word : keyVars) {
        //     System.out.println(word);
        // }
        int numKey = keyVars.length;
        // System.out.println(numKey);

        String key = "";
        String val = "";
        int numStr = 0;
        int numCol = 0;
        // String simvol = PARAMS.substring(i,i+1);

        for (int index = 0; index < numKey - 1; index++) {
            // int index = 0;
            key = keyVars[index];
            val = keyVars[index + 1];

            slovar[numStr][numCol] = key;
            slovar[numStr][numCol + 1] = val;

            // System.out.println(slovar[0][0]);
            // System.out.println(slovar[0][1]);
            if (index % 2 == 0) {
                numStr++;
            }
            // System.out.println(numStr);
        }

        // System.out.println(slovar[0][1]);

        sBuilder.append(QUERY);
        String keySl = "";
        String valSl = "";
        String woldSl = "";
        int flag = 0;
        for (int i = 0; i < 4; i++) {
            keySl = slovar[i][0];
            valSl = slovar[i][1];
            // System.out.println(valSl);
            if (flag == 0) {
                woldSl = (keySl + "=" + "'" + valSl + "'");
            } else {
                woldSl = (" and " + keySl + "=" + "'" + valSl + "'");
            }

            //if (valSl != "'null'") {
            if (valSl.equals("null")) 
                { }          
                else { sBuilder.append(woldSl); 
                    flag = 1;
                }

            // System.out.println(woldSl);
            // System.out.println(sBuilder);
        }
        //return sBuilder.toString();
        return sBuilder;
    }
}

// Эталонное решение

// Сформируйте SQL-запрос

// class Answer {  
//     public static StringBuilder answer(String QUERY, String PARAMS){
//         String paramsNew = PARAMS.replace('{',' ').replace('}', ' ');
//         String[] params = paramsNew.split(",");
//         StringBuilder stringBuilder = new StringBuilder(QUERY);

//         for (int i = 0; i < params.length; i++){
//             String[] elements = params[i].replace('"', ' ').split(":");
//             if(!"null".equals(elements[1].trim())){       
//               stringBuilder.append(elements[0].trim()).append("=").append("'").append(elements[1].trim()).append("'");
//                 if (i < params.length - 2) stringBuilder.append(" and ");
//             }
//         }
//         return stringBuilder;
//     }
// }


// public class Printer{ 
//     public static void main(String[] args) { 
//       String QUERY = "";
//       String PARAMS = "";

//       if (args.length == 0) {
//         QUERY = "select * from students where ";
//         PARAMS = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"} ";
//       }
//       else{
//         QUERY = args[0];
//         PARAMS = args[1];
//       }     

//       Answer ans = new Answer();      
//       System.out.println(ans.answer(QUERY, PARAMS));
//     }
// }