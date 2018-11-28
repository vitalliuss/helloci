helloci
=======

Test projects for Git training

Build
=======
Java project:
Tested on [JDK 9.0.4](http://www.oracle.com/technetwork/java/javase/downloads/jdk9-downloads-3848520.html), [Maven 3.5.2](http://maven.apache.org/download.cgi) and [Jenkins 2.109](mirrors.jenkins-ci.org/windows/jenkins-2.109.zip)
```
mvn clean test
```

.NET project: execute MSBuild
```
MSBuild Calculator.sln
```

Code coverage
========
Please note code coverage can't be measured on Java 9 due to open issue in cobertura: https://github.com/cobertura/cobertura/issues/271

Use Java 1.8 instead