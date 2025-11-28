var cleanTypeName = ShortNameMap.TryGetValue(type.Name, out var clean) ? clean : type.Name.String;
var cleanTypeName = ShortNameMap.TryGetValue(type.Name, out var clean) ? clean : (string)type.Name;
