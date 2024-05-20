# Currency-Exchange-Rate
Using the provided currency converter public API with C# - Rest API

First endpoint -> Retrieve the latest exchange rates for a specific base currency (e.g., EUR).
Second endpoint -> Allow users to convert amounts between different currencies. In case of TRY, PLN, THB, and MXN currency conversions, the endpoint should return a bad response and these currencies should be excluded from response. (These currencies should be excluded only for this endpoint! )
Third endpoint -> Return a set of historical rates for a given period using pagination based on a specific base currency. (e.g., 2020-01-01..2020-01-31, base EUR)

