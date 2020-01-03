
public class Wind {
public static void main(String[] args) {
double t=Double.parseDouble(args[0]);
double v=Double.parseDouble(args[1]);
double windChill=35.74+0.6215*t+(0.4275*t-35.75)*Math.pow(v, 0.16);
System.out.println("Given a temparature of"+t+"Fahrenheit"+" and a wind speed of "
+v+"mph");
System.out.println("The wind chill is "+windChill);
}

}
