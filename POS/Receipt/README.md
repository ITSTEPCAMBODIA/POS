# Receipt

## Package
**Namespace**: `Billing`
**Contains**:
- `Receipt` class
- `Bill` class

## Example
**example**:
```c#
Receipt R = new Receipt();
// set logo
R.LogoImage = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg");
// set info
R.Infos["one"] = 123;
R.Infos["two"] = "asdfasd";
R.Infos["three"] = "faaoiwnsadfa";
// set bills info
for (int i = 0; i < 5; i++)
    R.Bills.Add(new Bill($"test {i}", i, 2.3));
// show dialog
R.ShowDialog();
```

**example**
```c#
Dictionary<string, object> Infos = new Dictionary<string, object>();
Infos["one"] = 123;
Infos["two"] = "asdfasd";
Infos["three"] = "faaoiwnsadfa";
List<Bill> Bills = new List<Bill>();
for (int i = 0; i < 5; i++)
    Bills.Add(new Bill($"test {i}", i, 2.3));
Receipt.Show(
    Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"),
    Infos,
    Bills
);
```
