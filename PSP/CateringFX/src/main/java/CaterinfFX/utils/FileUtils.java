package CaterinfFX.utils;

import CaterinFX.model.*;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class FileUtils {
    public static String fileName_Aliments = "aliments.txt";
    public static String fileName_Dishes = "dishes.txt";

    //Function to load all the elements(Aliments and Dishes) in the table
    public static List<MenuElement> loadElements(){

        List<MenuElement> elements = new ArrayList<>();

        String separator = ";";
        if(new File(fileName_Aliments).exists() && new File(fileName_Dishes).exists()){

            try (Stream<String> streamAliments = Files.lines(Paths.get(fileName_Aliments));
                 Stream<String> streamDishes = Files.lines(Paths.get(fileName_Dishes));
            ){
                elements = streamAliments
                        .map(line -> new Aliment(
                                line.split(separator)[0],
                                line.split(separator)[1],
                                line.split(separator)[2],
                                Boolean.parseBoolean(line.split(separator)[3]),
                                Boolean.parseBoolean(line.split(separator)[4]),
                                Boolean.parseBoolean(line.split(separator)[5]),
                                Boolean.parseBoolean(line.split(separator)[6]),
                                Double.parseDouble(line.split(separator)[7]),
                                Double.parseDouble(line.split(separator)[8]),
                                Double.parseDouble(line.split(separator)[9])

                        )).collect(Collectors.toList());

                elements.addAll(streamDishes.map(line-> {
                    String[] parts = line.split(separator);
                    Dish dish = new Dish(parts[0], parts[1]);
                    for (int i = 2; i< parts.length; i +=11){
                        dish.addIngredient(new Ingredient(Double.parseDouble(parts[i]),
                                new Aliment(parts[i +1], parts[i+2], parts[i+3],
                                        Boolean.parseBoolean(parts[i+4]),
                                        Boolean.parseBoolean(parts[i+5]),
                                        Boolean.parseBoolean(parts[i+6]),
                                        Boolean.parseBoolean(parts[i+7]),
                                        Double.parseDouble(parts[i+8]),
                                        Double.parseDouble(parts[i+9]),
                                        Double.parseDouble(parts[i+10]))));
                    }
                    return dish;
                }).collect(Collectors.toList()));

            }catch (FileNotFoundException e1){
                System.out.println("File not found.");
                e1.printStackTrace();
            }catch (IOException e2){
                System.out.println("Error.");
                e2.printStackTrace();
            }
        }

        return elements;
    }

    //Function to store an aliment in the file aliments.txt
    public static void storeAliment(Aliment a){

        try(PrintWriter pw = new PrintWriter(
                new FileWriter(
                        Paths.get(fileName_Aliments).toAbsolutePath().toString(),
                        true)))
        {
            pw.println("\n" + a);

        }catch(IOException e1){
            System.out.println("Error while writing the Aliment.");
            e1.printStackTrace();
        }
    }

    //Function to store a Menu with the date as name
    public static void storeMenu(Menu m){

        final String MENU_FILENAME = m.getDate()+".menu.txt";
        try(PrintWriter pw = new PrintWriter(
                new FileWriter(
                        Paths.get(MENU_FILENAME).toAbsolutePath().toString(),
                        true)))
        {
            pw.println(m);

        }catch(IOException e1){
            System.out.println("An error occurred while write the Menu.");
            e1.printStackTrace();
        }
    }
}
