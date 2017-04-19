
# react-native-scrollview

## Getting started

`$ npm install react-native-scrollview --save`

### Mostly automatic installation

`$ react-native link react-native-scrollview`

### Manual installation

#### Android

1. Append the following lines to `android/settings.gradle`:
  	```
    include ':react-native-scrollview'
    project(':react-native-scrollview').projectDir = new File(rootProject.projectDir, '../node_modules/react-native-scrollview/android')

  	```
2. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-scrollview')
  	```


## Usage
```javascript
import ScrollView from 'react-native-scrollview';
