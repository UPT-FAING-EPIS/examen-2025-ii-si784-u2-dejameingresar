Feature: Music player commands

Scenario: Play song
    Given I have a music player
    When I press Play
    Then the result should be "Playing the song."

Scenario: Pause song
    Given I have a music player
    When I press Pause
    Then the result should be "Pausing the song."

Scenario: Skip song
    Given I have a music player
    When I press Skip
    Then the result should be "Skipping to the next song."