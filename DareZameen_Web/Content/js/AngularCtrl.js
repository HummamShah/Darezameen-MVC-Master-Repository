﻿var app = angular.module('DemoApp', []);

'use strict';
app.controller('DemoCtrl',
    [
        "$scope",
        "$rootScope",
        "$timeout",
        "$q",
        "$window",
        function ($scope, $rootScope, $timeout, $q, $window) {
            console.log("Connected to Demo App");
        }
    ]);

app.controller('InventoryCtrl',
    [
        "$scope",
        "$rootScope",
        "$timeout",
        "$q",
        "$window",
        "$http",
        function ($scope, $rootScope, $timeout, $q, $window,$http) {
            console.log("Connected to Inventory Ctrl");
            $scope.initIndex = function () {
                var data = null;
                var promise = $http.get("/api/InventoryApi/GetAllData", { params: data, headers: { 'Accept': 'application/json' } });
                promise.then(
                    function (response) {
                        console.log(response);
                        $scope.Inventories = response.data;
                    });
                // $scope.Inventories = $http.get("/api/InvenoryApi/GetAllData", { params: data, headers: { 'Accept': 'application/json' } });
            }

            $scope.AddInit = function () {

            }
            $scope.AddInventory = function (inventory) {
                console.log(inventory);
            }
        }
    ]); 