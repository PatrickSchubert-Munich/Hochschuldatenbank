# Hochschuldatenbank
Dieses Projekt ist im Rahmen meines Masterstudiums Wirtschaftsinformatik an der Universität Bamberg als Studienleistung entstanden.

Das Projekt einer Hochschuldatenbank, in der Dozenten, Studenten und Kurse in eine Hochschul-DB eingetragen werden können (CRUD - Operationen).
Studenten können Kurse besuchen und Dozenten halten Kurse. Deshalb ist es möglich, Studenten und Dozenten zu Kursen zuzuordnen. Herausfordernd 
hierbei war lt Aufgabenstellung, dass ein Kurs mit dem gleichem Namen in verschiedenen Semestern existieren kann. Aus diesem Grund wurde zuvor 
ein ERM-Datenmodell erstellt, sodass die erste, zweite und dritte Normalform eingehalten werden. Folglich sind die Daten konsistent. Dies macht
sich bemerkbar, wenn Daten auf der Hauptseite eingetragen werden sollen. Nur konsistente Daten sind zulässig. Vorteil an dieser Herangehensweise,
dass die Programmierarbeit erleichtert wird. Der Einfachheit wird die Datenbank als .mdf - Datei lokal gespeichert. 

Der Code wurde mit Visual Studio 2022 und dem .Net Framework Runtime v8.0 entwickelt. Für die UI wurde Windows Forms verwendet.
