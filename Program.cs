// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int score = 85;
char grade;

grade = score >= 90 ? 'A' : score >= 80 ? 'B' : score >= 70 ? 'C' : score >= 60 ? 'D' : 'F';

Console.WriteLine("Your grade is: " + grade);

// switch (score)
// {
//     case >= 90:
//         grade = 'A';
//         break;
//     case >= 80:
//         grade = 'B';
//         break;
//     case >= 70:
//         grade = 'C';
//         break;
//     case >= 60:
//         grade = 'D';
//         break;
//     default:
//         grade = 'F';
//         break;
// }

// if (score >= 90) {
//     grade = 'A';
// }
// else if (score >= 80) {
//     grade = 'B';
// }
// else if (score >= 70) {
//     grade = 'C';
// }
// else if (score >= 60) {
//     grade = 'D';
// }
// else {
//     grade = 'F';
// }