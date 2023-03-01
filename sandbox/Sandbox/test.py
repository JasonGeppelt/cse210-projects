total = 1000
withdraw = 123.16
denomination_list = (100, 50, 20, 10, 5, 1, .25, .1, .05, .01)

total -= withdraw
print(f'Change: {total}')

for denomination in denomination_list:
    amount = 0
    while total - denomination >= 0:
        total -= denomination
        amount += 1
    if amount > 0:
        print(f'{denomination}: {amount}')
	
        