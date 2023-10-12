using Microsoft.VisualBasic;

string[] states = new string[100];
int count = 0;

// Open File
StreamReader inFile = new StreamReader("states.txt");

// Process File

string line = inFile.ReadLine();

while(line != null){
    // Stores line in states array
    // We do not need to parse because
    // The only information we are storing
    // is the name.

    // The reason we convert to lower here
    // is that we want to clean our data
    // as it comes in, which makes it easier
    // to work with further down the road
    states[count] = line.ToLower();
    count++;

    // Read in next line of file
    line = inFile.ReadLine();   
}

// Close File
inFile.Close();
 

System.Console.WriteLine("What letter would you like to search on");

// Converts input to lower for easier comparison
// Parses into char so that we can look at first letter
// of name
char searchVal = char.Parse(Console.ReadLine().ToLower());

System.Console.WriteLine($"\n\nStates with name that starts with letter '{searchVal}':\n");

for(int i = 0; i < count; i++){
    // Stores the current one that we are on
    // in curr variable
    string curr = states[i];

    // Compares [0] to get first letter
    if(searchVal == curr[0]){
        System.Console.WriteLine(curr);
    }
}