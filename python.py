import math
def is_prime(n: int) -> int:
    a=2
    while a<=math.sqrt(n):
        if n%a<1:
            return 0
        a=a+1
    return 1 if n>1 else 0
 
primes_count = 0
 
for i in range(2, 250001):
    primes_count += is_prime(i)
 
print(primes_count)
