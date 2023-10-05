using Windows.UI.Xaml.Media.Animation;

namespace UWP.Markup.Transition;

/// <summary>
/// Provides extension methods for working with <see cref="TransitionCollection"/> in XAML animations.
/// </summary>
public static class TransitionCollectionMarkup
{
    /// <summary>
    /// Adds a <see cref="Windows.UI.Xaml.Media.Animation.Transition"/> to the <see cref="TransitionCollection"/>.
    /// </summary>
    /// <param name="transitions">The <see cref="TransitionCollection"/> to which the transition is added.</param>
    /// <param name="item">The <see cref="Windows.UI.Xaml.Media.Animation.Transition"/> to add to the collection.</param>
    /// <returns>The modified <see cref="TransitionCollection"/> with the added transition.</returns>
    public static TransitionCollection AddTransition(this TransitionCollection transitions, Windows.UI.Xaml.Media.Animation.Transition item)
    {
        transitions.Add(item);
        return transitions;
    }
}
