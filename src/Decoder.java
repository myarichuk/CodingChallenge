import java.security.InvalidParameterException;

public class Decoder {
    public static String Process(String data)
    {
        for (int i = 0; i < data.length(); i++) {
            Character c = data.charAt(i);
            if(!(Character.isLetterOrDigit(c) && Character.isLowerCase(c)))
                throw new InvalidParameterException("Invalid input");
        }

        String decodedData = data;

        return decodedData;
    }
}
