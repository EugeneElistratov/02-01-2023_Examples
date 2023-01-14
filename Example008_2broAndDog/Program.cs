// Два друга идут навстречу друг другу - дистанция 10000, скорость: друг1 = 1, друг2 = 2, собака = 5. 
// Сколько раз собака пробежит между друзьями?
int count = 0;
double distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;
while (distance > 10)
{
if (friend == 1)
{
time = distance / (firstFriendSpeed + dogSpeed);
friend = 2;
Console.WriteLine("time to firstFriend = " + time);
}
else
{
time = distance / (secondFriendSpeed + dogSpeed);
friend = 1;
Console.WriteLine("time to secondFriend = " + time);
}
distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time);
Console.WriteLine("distance = " + distance);
count++;
}
Console.Write("Собака пробежит " + count + " раз.");
Console.WriteLine();
