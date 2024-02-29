#![feature(isqrt)]

fn is_prime(n: i32) -> i32 {
    let mut a: i32 = 2;
    while a <= n.isqrt() {
        if (&n % &a < 1) {
            return 0;
        }
        a += 1;
    }
    if (n > 1) {
        return 1;
    }
    return 0;
}

fn main() {
    let mut primes_count  = 0;
    for i in (0..250001) {
        primes_count += is_prime(i);
    }
    println!("{:?}", &primes_count);
}
