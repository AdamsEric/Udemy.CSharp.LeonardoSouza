var Produto = /** @class */ (function () {
    function Produto() {
    }
    Produto.prototype.obterNome = function () {
        return this.nome;
    };
    Produto.prototype.obterId = function () {
        return this.id;
    };
    Object.defineProperty(Produto.prototype, "descricao", {
        get: function () {
            return this.nome;
        },
        set: function (val) {
        },
        enumerable: true,
        configurable: true
    });
    return Produto;
}());
var produto = new Produto();
//# sourceMappingURL=produto.js.map