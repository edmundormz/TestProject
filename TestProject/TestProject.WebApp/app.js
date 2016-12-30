(function () {
    'use strict';

    angular.module('app', []).controller(function($scope) {
        
        $scope.listaProyectos = [
           { nombre: "A", lenguaje: "Visual C#", tipo: "Web", horas: 1000 },
           { nombre: "B", lenguaje: "Visual Basic", tipo: "Mobile", horas: 250 },
           { nombre: "C", lenguaje: "TypeScript", tipo: "Web", horas: 2000 }];

    })});