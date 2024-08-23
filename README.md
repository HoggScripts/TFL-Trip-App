# TFL-Trip-App
The TfL Trip Planner is a C# console application designed for two primary users: regular TfL commuters and TfL engineers. Commuters can find the fastest routes between stations using Dijkstra’s Shortest Path algorithm, while engineers can manage network delays, track closures, and generate relevant reports.

The application is available in two versions: a hand-coded version that builds custom data structures from scratch and a version leveraging .NET's built-in data structures. Both versions yield the same outcomes, but performance varies.

The software employs the Model-View-Controller (MVC) pattern for clear separation of concerns, enhancing maintainability and scalability. The hand-coded version includes custom structures like CustomDictionary, CustomList, and HandCodedMinHeap, designed to meet the project's specific requirements without relying on .NET libraries. The .NET version, in contrast, uses efficient built-in data structures such as dictionaries and lists, resulting in better performance.

Extensive testing, including unit tests and performance comparisons, was conducted to ensure the accuracy and efficiency of both versions. The analysis demonstrated that the .NET version is faster and more memory-efficient, though both versions are accurate in finding the shortest path.

In summary, the TfL Trip Planner successfully addresses the challenge of navigating the complex London transport network, offering valuable insights into the trade-offs between custom data structure implementation and using modern programming libraries.
