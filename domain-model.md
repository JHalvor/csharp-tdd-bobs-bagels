# Domain Models In Here

## User Story 1:
```
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.
```

**Domain Model**:
| Classes  | Methods               | Scenario                     | Outputs     |
|----------|-----------------------|------------------------------|-------------|
| `Basket` | `Add(string product)` | Add specific bagel to basket | bool (true) |


## User Story 2:
```
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.
```

**Domain Model**:
| Classes  | Methods                  | Scenario                               | Outputs     |
|----------|--------------------------|----------------------------------------|-------------|
| `Basket` | `Remove(string product)` | Remove specified bagel from basket     | bool (true) |


## User Story 3:
```
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
```

**Domain Model**:
| Classes  | Methods               | Scenario                     | Outputs      |
|----------|-----------------------|------------------------------|--------------|
| `Basket` | `Add(string product)` | Add item when basket is full | bool (False) |


## User Story 4:
```
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.
```

**Domain Model**:
| Classes  | Methods                | Scenario                                                                     | Outputs      |
|----------|------------------------|------------------------------------------------------------------------------|--------------|
| `Basket` | `ChangeSize(int size)` | Change basket size to a increased size                                       | Bool (true)  |
| `Basket` | `ChangeSize(int size)` | Change basket size to a decreased size smaller than number of elements in it | Bool (false) |


## User Story 5:
```
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
```

**Domain Model**:
| Classes  | Methods                  | Scenario                                                | Outputs      |
|----------|--------------------------|---------------------------------------------------------|--------------|
| `Basket` | `Remove(string product)` | Remove specified product that doesn't exist from basket | bool (False) |