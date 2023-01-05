// Задача про двух друзей и собаку, которая бегает между ними,
// пока они идут навстречу друг другу. Сколько раз собака пробежит между друзьями?
int count = 0;
double distance = 80000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
double time = 0;
while (distance > 10)
{
    if (friend == 1);
    {
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = 2;
    }
    {
    time = distance / (secondFriendSpeed + dogSpeed);
    friend = 1;
    }
    distance = distance - ((firstFriendSpeed + secondFriendSpeed) * time);
    count++;
}
Console.Write("Собака пробежит " + count + " раз.");
Console.WriteLine();
