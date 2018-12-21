public class IpAddressesSorter
    {
        private List<int[]> _numericIpAddresses = new List<int[]>();
        public bool Descending { get; set; }
    
        public IpAddressesSorter(IEnumerable<string> ipAddresses)
        {
            Descending = false;
            foreach (var ipAddress in ipAddresses)
            {
                _numericIpAddresses.Add(ConvertToNumericIpAddress(ipAddress));
            }
        }

        private static int[] ConvertToNumericIpAddress(string ipAddress)
        {
            var octets = ipAddress.Split('.');
            return new[]
            {
                Convert.ToInt32(octets[0]),
                Convert.ToInt32(octets[1]),
                Convert.ToInt32(octets[2]),
                Convert.ToInt32(octets[3])
            };
        }

        public List<string> SortIpAddresses()
        {
            if (!Descending)
            {
                _numericIpAddresses = _numericIpAddresses.OrderBy(address => address[3]).ToList();
                _numericIpAddresses = _numericIpAddresses.OrderBy(address => address[2]).ToList();
                _numericIpAddresses = _numericIpAddresses.OrderBy(address => address[1]).ToList();
                _numericIpAddresses = _numericIpAddresses.OrderBy(address => address[0]).ToList();
            }
            else
            {
                _numericIpAddresses = _numericIpAddresses.OrderByDescending(address => address[3]).ToList();
                _numericIpAddresses = _numericIpAddresses.OrderByDescending(address => address[2]).ToList();
                _numericIpAddresses = _numericIpAddresses.OrderByDescending(address => address[1]).ToList();
                _numericIpAddresses = _numericIpAddresses.OrderByDescending(address => address[0]).ToList();
            }
            var sortedIpAddresses = new List<string>();
            foreach (var numericIpAddress in _numericIpAddresses)
            {
                sortedIpAddresses.Add(
                    $"{numericIpAddress[0]}." +
                    $"{numericIpAddress[1]}." +
                    $"{numericIpAddress[2]}." +
                    $"{numericIpAddress[3]}");
            }
            return sortedIpAddresses;
        }
    }
