// %(деление по модулю):

int timeToMinets = 130;
int hour;
int minute;

hour = timeToMinets / 60;
minute = timeToMinets % 60;

Console.WriteLine("Hours: " + hour);
Console.WriteLine("Minutes: " + minute);