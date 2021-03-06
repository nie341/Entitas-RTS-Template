//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public KeyEventComponent keyEvent { get { return (KeyEventComponent)GetComponent(InputComponentsLookup.KeyEvent); } }
    public bool hasKeyEvent { get { return HasComponent(InputComponentsLookup.KeyEvent); } }

    public void AddKeyEvent(Hotkey newValue) {
        var index = InputComponentsLookup.KeyEvent;
        var component = CreateComponent<KeyEventComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceKeyEvent(Hotkey newValue) {
        var index = InputComponentsLookup.KeyEvent;
        var component = CreateComponent<KeyEventComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveKeyEvent() {
        RemoveComponent(InputComponentsLookup.KeyEvent);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherKeyEvent;

    public static Entitas.IMatcher<InputEntity> KeyEvent {
        get {
            if (_matcherKeyEvent == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.KeyEvent);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherKeyEvent = matcher;
            }

            return _matcherKeyEvent;
        }
    }
}
