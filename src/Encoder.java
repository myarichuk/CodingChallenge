import java.security.InvalidParameterException;

public class Encoder {
    public static String Process(String data)
    {
        for (int i = 0; i < data.length(); i++) {
            Character c = data.charAt(i);
            if(!(Character.isLetter(c) && Character.isLowerCase(c)))
                throw new InvalidParameterException("Invalid input");
        }

        String encodedData = data;

        return encodedData;
    }
}
