import numbers

userInput = 0

while True:
    try:
        userInput = int(input("enter an integer 'n': "))
    except ValueError:
        print("please ensure you have entered an integer: ")
        continue
    else:
        break

fibonnaciY = 0
fibonnaciX = 1

counter = 1

while counter < userInput:
    fibonnaciN = fibonnaciX + fibonnaciY
    fibonnaciX = fibonnaciY
    fibonnaciY = fibonnaciN
    counter += 1

print(f"{userInput}th number in Fib sequence = {fibonnaciN}")