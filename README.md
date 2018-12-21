# IpAddressesSorter
C# Class that sorts (ascending/descending) IP addresses using the value of the octets. Generally IP addresses are a list of strings. So when sorting, the order is not based on the value of the octets.

I might get this:
```
10.0.0.1
10.0.0.111
10.0.0.2
```
Where I want this:

```
10.0.0.1
10.0.0.2
10.0.0.111
```
## How to use
```c#
// Instantiate with the list of IP addresses (List<string>). By default the sort is ascending.
var ipAddressesSorter = new IpAddressesSorter(ipAddresses);
// To sort descending
ipAddressesSorter.Descending = true;
// Call the sort method. It returns a List<string>
ipAddressesSorter.SortIpAddresses();
```
