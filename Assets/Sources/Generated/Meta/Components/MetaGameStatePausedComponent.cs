//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaContext {

    public MetaEntity gameStatePausedEntity { get { return GetGroup(MetaMatcher.GameStatePaused).GetSingleEntity(); } }

    public bool isGameStatePaused {
        get { return gameStatePausedEntity != null; }
        set {
            var entity = gameStatePausedEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isGameStatePaused = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MetaEntity {

    static readonly GameStatePausedComponent gameStatePausedComponent = new GameStatePausedComponent();

    public bool isGameStatePaused {
        get { return HasComponent(MetaComponentsLookup.GameStatePaused); }
        set {
            if (value != isGameStatePaused) {
                var index = MetaComponentsLookup.GameStatePaused;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : gameStatePausedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class MetaMatcher {

    static Entitas.IMatcher<MetaEntity> _matcherGameStatePaused;

    public static Entitas.IMatcher<MetaEntity> GameStatePaused {
        get {
            if (_matcherGameStatePaused == null) {
                var matcher = (Entitas.Matcher<MetaEntity>)Entitas.Matcher<MetaEntity>.AllOf(MetaComponentsLookup.GameStatePaused);
                matcher.componentNames = MetaComponentsLookup.componentNames;
                _matcherGameStatePaused = matcher;
            }

            return _matcherGameStatePaused;
        }
    }
}
