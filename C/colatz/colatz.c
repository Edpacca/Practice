#include <math.h>
#include <stdio.h>

#include <cs50.h>

int REPEATS = 5000;

int get_number(string prompt);
int number, even, odd, count;

int main(void)
{


    // int starting_num[ARRAY_SIZE];

    // for (int = 0; i < ARRAY_SIZE; i++)
    // {
    //     starting_num[i] = 0;
    // }



    FILE *file = fopen("Colatz_data.txt", "w");

    if (file != NULL)
    {
        printf("File created successfully!\n");
    }
    else
    {
        printf("Failed to create the file.\n");
        return 1;
    }

    count = 1;

    for (int i = 0; i < REPEATS; i++)
    {
        count += 2;
        even = 0, odd = 0;
        number = count;
        // starting_num[i] = number;

        do
        {
            if (number == 1)
            {
                odd++;
                // printf("%i\n", number);
                fprintf(file, "%i ", number);
                break;
            }

            else if (number % 2 != 0)
            {
                odd++;
                // printf("%i ", number);
                fprintf(file, "%i ", number);
                number = (number * 3) + 1;
            }

            while(number % 2 == 0)
            {
                even++;
                // printf("%i ", number);
                fprintf(file, "%i ", number);
                number /= 2;
            }
        }
        while(number % 2 != 0);
    // printf("even: %i, odd: %i, total: %i\n\n", even, odd, even + odd);
    fprintf(file, "%i %i\n", odd, even);


    }
    fclose(file);
}

int get_number(string prompt)
{
    int num;
    do
    {
        num = get_int("%s", prompt);
    }
    while (num <= 0);
    return num;

}