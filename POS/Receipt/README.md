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
